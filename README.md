# Role-Based Chatbot Project

## Description
A .NET MVC chatbot application that allows users to set custom roles for both the chatbot and themselves, enabling versatile conversational experiences.

## Prerequisites
- .NET MVC Framework
- Ollama
- Llama3 Local Model

## Installation

### 1. Install Ollama
Download Ollama from the official website: [Ollama Download](https://ollama.com/download)

#### Quick Installation Commands
- **Windows**: 
  ```
  winget install ollama
  ```
- **macOS**: 
  ```
  brew install ollama
  ```
- **Linux**: 
  ```
  curl https://ollama.ai/install.sh | sh
  ```

### 2. Pull Llama3 Model
```bash
ollama pull llama3
```

### 3. Project Setup
1. Download the project ZIP file
2. Extract the ZIP file to your desired directory
   ```
   # Example extraction command
   unzip chatbot-project.zip -d chatbot-project
   ```

### 4. Configure Project
- Open the solution in Visual Studio
- Restore NuGet packages
- Update connection strings if necessary
- Set up Ollama connection in `appsettings.json`

### 5. Running the Application
- Open terminal/command prompt
- Navigate to project directory
- Run the application:
  ```
  dotnet run
  ```

## Features
- Dynamic role selection for chatbot
- Customizable user roles
- Local AI model integration
- .NET MVC architecture

## Configuration
Modify `appsettings.json` to configure:
- Ollama endpoint
- Model settings
- Role definitions

## Troubleshooting
- Ensure Ollama is running
- Check model download
- Verify .NET SDK installation

## Contributing
1. Fork the repository
2. Create feature branch
3. Commit changes
4. Push to branch
5. Create pull request

## License
[Specify your license here]

## Contact
[Your contact information]
