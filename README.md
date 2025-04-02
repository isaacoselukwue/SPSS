# SPSS - University Cost Comparison

**SPSS - University and City Cost Comparison** is a web application that helps students compare the cost of living in different university cities across the UK. This tool provides comprehensive cost breakdowns including accommodation, groceries, and entertainment expenses to help students make informed decisions about where to study.

## Features

- **City Search:** Find cities by name or browse all available options.
- **City Comparison:** Compare up to 3 cities side by side.
- **Cost Breakdown:** View detailed weekly expenses for accommodations, groceries, and entertainment.
- **Accommodation Details:** Get information about both university halls and private housing options.
- **University Information:** See university-specific data within each city, including nearby supermarkets and costs.
- **Employment Information:** View available student jobs, median wages, and employment rates.

## Technology Stack

- **Backend:** ASP.NET Core
- **Frontend:** Blazor WebAssembly
- **Styling:** Bootstrap 5.3
- **Data Storage:** Local JSON files

## Screenshots

![Home Page](https://i.imgur.com/CWtQxcP.png)
![Search](https://i.imgur.com/7BlSd8d.png)
![Compare](https://i.imgur.com/ZfYWmY4.png)

## Live Demo

[View Live Demo](https://spss-e4yn.onrender.com)  

## Setup Instructions

1. **Clone the Repository**

   ```bash
   git clone https://github.com/yourusername/SPSS.git
2. **Navigate to the project directory**
    ```
    cd SPSS/SPSS
3. **Restore dependencies**
    ```
    dotnet restore
4. **Run the application**
    ```
    dotnet run
5. **Open your browser and navigate to**
    ```
    https://localhost:5001

## Usage
1. **Type a city name in the search box**
2. **Select a city from the search results**
3. **View detailed cost information for the selected city**
4. **Add up to 3 cities to compare using the "Compare with other cities" button**
5. **Review the cost breakdown and housing options**
6. **View university-specific information within each city**

## Data Sources
The application uses local JSON data files for university and city information. These files can be found in the `wwwroot/data/` directory.

## License
This project is licensed under the MIT License.