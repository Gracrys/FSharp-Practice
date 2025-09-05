type Book(name: string, authorName: string, year: int, price: int, isbn: string) =
    member this.Name = name
    member this.AuthorName = authorName
    member this.Year = year
    member this.Price = price
    member this.Isbn = isbn




type Invoice(Book:Book, quantity:int, discountRate: double, taxRate: double  ) =
        member this.Book = Book
        member this.Quantity = quantity 
        member this.DiscountRate = discountRate
        member this.TaxRate = taxRate
        member this.total = this.calculateTotal()

        member this.calculateTotal(): double =
            let price = float this.Book.Price * (1.0 - this.DiscountRate)
            price * (1.0 + this.TaxRate)
            
