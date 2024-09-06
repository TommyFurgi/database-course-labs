//package org.example;
//
//import org.hibernate.Session;
//import org.hibernate.SessionFactory;
//import org.hibernate.Transaction;
//import org.hibernate.cfg.Configuration;
//
//import javax.management.InvalidAttributeValueException;
//import java.util.List;
//import java.util.Set;
//
//public class Main {
//    private static SessionFactory sessionFactory = null;
//
//    public static void main(String[] args) throws InvalidAttributeValueException {
//        sessionFactory = getSessionFactory();
//        Session session = sessionFactory.openSession();
//
//        Transaction tx = session.beginTransaction();
//
//        Invoice inv = session.get(Invoice.class, 1);
//        Set<Product> products = inv.getProducts();
//        System.out.println("Produkty na fakturze: " + inv);
//        for (Product product: products) {
//            System.out.println(product);
//        }
//
//        System.out.println();
//        Product prod = session.get(Product.class, 1);
//        System.out.println(prod + " znajduje sie na fakturze: " + prod.getInvoices());
//
//        tx.commit();
//
//
//        session.close();
//    }
////        Product product = new Product("Rower", 2);
////        Transaction tx = session.beginTransaction();
////        session.save(product);
////        tx.commit();
//
////        Supplier supplier = new Supplier("Firma", "kościuszki", "Poznań");
////        Product product1 = session.get(Product.class, 2);
////        Product product2 = session.get(Product.class, 3);
////
////        supplier.addProduct(product1);
////        supplier.addProduct(product2);
////        Transaction tx = session.beginTransaction();
////        session.save(supplier);
////        tx.commit();
//    private static SessionFactory getSessionFactory() {
//        if (sessionFactory == null) {
//            Configuration configuration = new Configuration();
//            sessionFactory = configuration.configure().buildSessionFactory();
//        }
//        return sessionFactory;
//    }
//
//}
