package org.example;

import javax.management.InvalidAttributeValueException;
import jakarta.persistence.*;
import org.hibernate.cfg.Configuration;

public class Main2 {
    private static final EntityManagerFactory emf;

    static {
        try {
            emf = Persistence.createEntityManagerFactory("derby");
        } catch (Throwable ex) {
            throw new ExceptionInInitializerError(ex);
        }
    }
    public static EntityManager getEntityManager() {
        return emf.createEntityManager();
    }

    public static void main(String[] args) {
        EntityManager em = getEntityManager();
        EntityTransaction etx = em.getTransaction();

        etx.begin();

        Product product1 = new Product("Telewizor", 12);
        Product product2 = new Product("Tablet", 10);
        Product product3 = new Product("Buty", 2);

        Invoice invoice1 = new Invoice();
        Invoice invoice2 = new Invoice();

        try {
            product1.sell(invoice1, 2);
            product2.sell(invoice1, 3);

            invoice1.addProduct(product1, 2);
            invoice1.addProduct(product2, 3);

            product2.sell(invoice2, 5);
            product3.sell(invoice2, 1);

            invoice1.addProduct(product2, 5);
            invoice1.addProduct(product3, 1);
        } catch (InvalidAttributeValueException e) {
            e.printStackTrace();
        }
        em.persist(invoice1);
        em.persist(invoice2);

        em.persist(product1);
        em.persist(product2);
        em.persist(product3);

        etx.commit();

        em.close();
    }
}

