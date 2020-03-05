/* Task Description */
/* 
	*	Create a module for working with books
		*	The module must provide the following functionalities:
			*	Add a new book to category
				*	Each book has unique title, author and ISBN
				*	It must return the newly created book with assigned ID
				*	If the category is missing, it must be automatically created
			*	List all books
				*	Books are sorted by ID
				*	This can be done by author, by category or all
			*	List all categories
				*	Categories are sorted by ID
		*	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
			*	When adding a book/category, the ID is generated automatically
		*	Add validation everywhere, where possible
			*	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
			*	Author is any non-empty string
			*	Unique params are Book title and Book ISBN
			*	Book ISBN is an unique code that contains either 10 or 13 digits
			*	If something is not valid - throw Error
*/
function solve() {
	var library = (function () {
		var bookID = 0, 
			categoryID = 0,
			categories = [],
			books = [];

		function listBooks(property) {
			var temp = books.slice();
			if (property) {
				var prop;
				for (prop in property) {
					if (property.hasOwnProperty(prop)) {
						temp = books.filter(function(item) {
							return item[prop] === property[prop];
						});
					}
				}
			}
			books = temp.slice();
			return books.sort (function(a,b){
				return a.id - b.id;
			});
		}

		function addBook(book) {
			var bookToAdd,
				categoryToAdd,
				categoryIndex;
			if(books.every(function(item){
				return (item.title !== book.title &&
						item.isbn !== book.isbn);
			})) {
				bookToAdd = new Book(book);
				books.push(bookToAdd);
			} else {
				throw 'Title of every book is unique';
			}

			if (!categories.some(function(item, index) {
				categoryIndex = index;
				return item.name === book.category;
			})) {
				categoryToAdd = new Category(book.category);
				categoryToAdd.books.push(bookToAdd);
				categories.push(categoryToAdd);
			} else {
				categories[categoryIndex].books.push(bookToAdd);
			}

			return bookToAdd;
		}

		function listCategories() {
			return categories.sort(function(a, b){
				return a.id - b.id;
			}).map(function(item) {
				item = item.name;
				return item;
			});
		}

		function Book(book) {
			if(typeof book.title !== 'string' || book.title.length < 2 || book.title.length > 100) {
				throw 'Title must be between 2 and 10 characters long';
			}
			if (typeof book.author !== 'string' || book.author === '') {
				throw 'Author must be a non-empty string';
			}
			if (typeof book.isbn !== 'string' || (book.isbn.length !== 10 && book.isbn.length !==13) || book.isbn.split('').every(function(item){
				return isNaN(item);
			})) {
				throw 'ISBN should be string containing 10 or 13 digits';
			}
			this.ID = ++bookID;
			this.title = book.title;
			this.author = book.author;
			this.isbn = book.isbn;
			this.category = book.category;
		}

		function Category (name) {
			if (typeof name !== 'string' || name.length < 2 || name.length > 100) {
				throw 'Category name must be between 2 and 100 characters';
			}
			this.ID = ++categoryID;
			this.name = name;
			this.books = [];
		}
		return {
			books: {
				list: listBooks,
				add: addBook
			},
			categories: {
				list: listCategories
			}
		};
	} ());
	return library;
}
module.exports = solve;
