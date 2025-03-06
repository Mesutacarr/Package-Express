def calculate_shipping():
    print("Welcome to SwiftShip! Please follow the instructions below.")
    
    # Prompt user for package weight
    weight = float(input("Input the package weight (lbs): "))
    
    # Check weight restriction
    if weight > 50:
        print("Apologies, your package exceeds our weight limit. Have a great day!")
        return
    
    # Gather package dimensions
    width = float(input("Input the package width (inches): "))
    height = float(input("Input the package height (inches): "))
    length = float(input("Input the package length (inches): "))
    
    # Validate total dimension size
    if (width + height + length) > 50:
        print("Regretfully, your package exceeds our size restrictions.")
        return
    
    # Compute estimated shipping price
    cost = (width * height * length * weight) / 100
    
    # Display the shipping estimate
    print(f"Your estimated shipping cost is: ${cost:.2f}")
    print("Thank you for choosing SwiftShip!")

# Run the shipping calculator
calculate_shipping()