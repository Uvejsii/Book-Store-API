# Bookstore API

This is a simple RESTful API for managing books in a bookstore. It allows you to perform CRUD (Create, Read, Update, Delete) operations on books.

## Table of Contents
- [Features](#features)
- [Endpoints](#endpoints)
- [Getting Started](#getting-started)

## Features
- Retrieve all exisiting books
- Retrieve a book by ID
- Search for books by book name
- Search for books by book author
- Search for books by book pages
- Search for books by book price
- Create a new book
- Update a book's information
- Delete a book

## Endpoints
- `GET /books`: Retrieve all exisiting books.
- `GET /book/{id}`: Retrieve a book by its ID.
- `GET /searchBook/{bookName}`: Search for books by their book name.
- `GET /searchAuthor/{bookAuthor}`: Search for books by their book author.
- `GET /searchPages/{bookPages}`: Search for books by their book pages.
- `GET /searchPrice/{bookPrice}`: Search for books by their book price.
- `POST /book`: Create a new book.
- `PUT /book/{id}`: Update a book's information by its ID.
- `DELETE /book/{id}`: Delete a book by its ID.

## Getting Started
To get started with the API, follow these steps:

1. **Clone the repository:**
   ```bash
   git clone https://github.com/Uvejsii/Book-Store-API.git

2. **Install dependencies:**
  ```bash
  npm install

3. **Set up the database:**
   ```bash
    dotnet ef database update

4. **Run the API:**
   ```bash
   dotnet run
