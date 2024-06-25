PGDMP                      |            empresaX    16.3    16.3     �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    16396    empresaX    DATABASE     �   CREATE DATABASE "empresaX" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Portuguese_Brazil.1252';
    DROP DATABASE "empresaX";
                postgres    false            �            1259    16433    customer    TABLE     �   CREATE TABLE public.customer (
    id integer NOT NULL,
    name character varying(100) NOT NULL,
    address character varying(250) NOT NULL,
    phone character varying(20) NOT NULL,
    email character varying(100)
);
    DROP TABLE public.customer;
       public         heap    postgres    false            �            1259    16432    customer_id_seq    SEQUENCE     �   CREATE SEQUENCE public.customer_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 &   DROP SEQUENCE public.customer_id_seq;
       public          postgres    false    216                        0    0    customer_id_seq    SEQUENCE OWNED BY     C   ALTER SEQUENCE public.customer_id_seq OWNED BY public.customer.id;
          public          postgres    false    215            �            1259    16440    product    TABLE     �   CREATE TABLE public.product (
    id integer NOT NULL,
    name character varying(100) NOT NULL,
    description character varying(250) NOT NULL,
    price integer NOT NULL,
    qty integer NOT NULL
);
    DROP TABLE public.product;
       public         heap    postgres    false            �            1259    16439    product_id_seq    SEQUENCE     �   CREATE SEQUENCE public.product_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 %   DROP SEQUENCE public.product_id_seq;
       public          postgres    false    218                       0    0    product_id_seq    SEQUENCE OWNED BY     A   ALTER SEQUENCE public.product_id_seq OWNED BY public.product.id;
          public          postgres    false    217            �            1259    16447    sale    TABLE     �   CREATE TABLE public.sale (
    id integer NOT NULL,
    customer_id integer NOT NULL,
    product_id integer NOT NULL,
    qty integer NOT NULL
);
    DROP TABLE public.sale;
       public         heap    postgres    false            �            1259    16446    sale_id_seq    SEQUENCE     �   CREATE SEQUENCE public.sale_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 "   DROP SEQUENCE public.sale_id_seq;
       public          postgres    false    220                       0    0    sale_id_seq    SEQUENCE OWNED BY     ;   ALTER SEQUENCE public.sale_id_seq OWNED BY public.sale.id;
          public          postgres    false    219            Z           2604    16436    customer id    DEFAULT     j   ALTER TABLE ONLY public.customer ALTER COLUMN id SET DEFAULT nextval('public.customer_id_seq'::regclass);
 :   ALTER TABLE public.customer ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    216    215    216            [           2604    16443 
   product id    DEFAULT     h   ALTER TABLE ONLY public.product ALTER COLUMN id SET DEFAULT nextval('public.product_id_seq'::regclass);
 9   ALTER TABLE public.product ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    217    218    218            \           2604    16450    sale id    DEFAULT     b   ALTER TABLE ONLY public.sale ALTER COLUMN id SET DEFAULT nextval('public.sale_id_seq'::regclass);
 6   ALTER TABLE public.sale ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    220    219    220            �          0    16433    customer 
   TABLE DATA           C   COPY public.customer (id, name, address, phone, email) FROM stdin;
    public          postgres    false    216   i       �          0    16440    product 
   TABLE DATA           D   COPY public.product (id, name, description, price, qty) FROM stdin;
    public          postgres    false    218   �       �          0    16447    sale 
   TABLE DATA           @   COPY public.sale (id, customer_id, product_id, qty) FROM stdin;
    public          postgres    false    220   �                  0    0    customer_id_seq    SEQUENCE SET     >   SELECT pg_catalog.setval('public.customer_id_seq', 34, true);
          public          postgres    false    215                       0    0    product_id_seq    SEQUENCE SET     =   SELECT pg_catalog.setval('public.product_id_seq', 24, true);
          public          postgres    false    217                       0    0    sale_id_seq    SEQUENCE SET     :   SELECT pg_catalog.setval('public.sale_id_seq', 19, true);
          public          postgres    false    219            ^           2606    16438    customer customer_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.customer
    ADD CONSTRAINT customer_pkey PRIMARY KEY (id);
 @   ALTER TABLE ONLY public.customer DROP CONSTRAINT customer_pkey;
       public            postgres    false    216            `           2606    16445    product product_pkey 
   CONSTRAINT     R   ALTER TABLE ONLY public.product
    ADD CONSTRAINT product_pkey PRIMARY KEY (id);
 >   ALTER TABLE ONLY public.product DROP CONSTRAINT product_pkey;
       public            postgres    false    218            b           2606    16452    sale sale_pkey 
   CONSTRAINT     L   ALTER TABLE ONLY public.sale
    ADD CONSTRAINT sale_pkey PRIMARY KEY (id);
 8   ALTER TABLE ONLY public.sale DROP CONSTRAINT sale_pkey;
       public            postgres    false    220            c           2606    16453    sale sale_customer_id_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.sale
    ADD CONSTRAINT sale_customer_id_fkey FOREIGN KEY (customer_id) REFERENCES public.customer(id);
 D   ALTER TABLE ONLY public.sale DROP CONSTRAINT sale_customer_id_fkey;
       public          postgres    false    216    220    4702            d           2606    16458    sale sale_product_id_fkey    FK CONSTRAINT     }   ALTER TABLE ONLY public.sale
    ADD CONSTRAINT sale_product_id_fkey FOREIGN KEY (product_id) REFERENCES public.product(id);
 C   ALTER TABLE ONLY public.sale DROP CONSTRAINT sale_product_id_fkey;
       public          postgres    false    4704    220    218            �      x������ � �      �      x������ � �      �      x������ � �     