# SPSS - University Cost Comparison

**SPSS - University Cost Comparison** is a web application that helps students compare the cost of attending different universities in the UK. This tool provides comprehensive cost breakdowns including accommodation, groceries, and entertainment expenses to help students make informed decisions.

## Features

- **University Search:** Find universities by name or city.
- **Cost Comparison:** Compare up to 3 universities side by side.
- **Cost Breakdown:** View detailed weekly expenses for accommodations, groceries, and entertainment.
- **Duration Selection:** Calculate costs for the standard academic year (44 weeks) or the full year (51 weeks).
- **Employment Information:** View available student jobs, median wages, and employment rates.
- **Accommodation Details:** Get information about both university-owned and private accommodations.

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
1. **Type a university name or city in the search box**
2. **Select a university from the search results**
3. **Add up to 3 universities to compare**
4. **Choose between 44-week or 51-week duration**
5. **Review the cost breakdown and total expenses**
6. **Click "Visit University Website" to learn more about a specific institution**

## Data Sources
The application uses local JSON data files for university and city information. These files can be found in the `wwwroot/data/` directory.

## License
This project is licensed under the MIT License.