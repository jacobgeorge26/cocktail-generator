# Planning

There will be three (initial) stages to the project.
1. The proof of concept will mainly demonstrate that it is possible to generate cocktail recipes for a specific list of ingredients using OpenAI. The code does not need to be polished; it merely aims to demonstrate that the project is viable and establish a skeleton off which to build.
2. Version 1.0.0 will cover the MVP of the website. The functionality will be limited, covering only the main goals, but will be polished with good test coverage and seamless deployment.
3. Version 2.0.0 will add additional functionality to improve the usability of the website. Any tech debt / bugs that have surfaced since the 1.0.0 release should be prioritised.

## PoC

### UI

The UI will be basic and allow the user to do the following:
- Input a list of cocktail ingredients
- View the ingredients and a brief description of three cocktail options
- Expand a cocktail in order to view the methodology
- Save a cocktail recipe
- View the saved cocktails

### AI

The AI service does not need to be effective, but it should:
- Query OpenAI in a structured way using the user input and some default values
- Validate the response to ensure it does not use any ingredients the user has not specified
- Return the results as an object
- Consider any saved cocktails using similar ingredients

### DB

The database will use EF Core and should allow for cocktail recipes to be saved and fetched. It will not be set up for user accounts just yet.

### Deployment

The PoC will be deployed locally only. Options will be used to serve default values provided in appsettings, but these will not be overriden from GitHub Actions just yet. 

## 1.0.0

### UI

The UI should be more polished. The layout will be designed in more detail in the more granular planning.

At the high level there will likely be three main pages for users to:
- Generate cocktails
- Login / manage their account
- View their saved cocktails

### AI

The request and response should be more structured and the various algorithms should be explored to determine which one(s) to utilise.

The main goals, building on the ones covered by the PoC, are to:

- Allow user to choose how many cocktails to fetch at a time
- Provide a mix of 'safe' and 'experimental' cocktails
- Tweak a previous cocktail
- Provide prompts for the cocktail (e.g. _sour_, _fruity_, _amaretto-base_)
- Allow 'assumed' ingredients to be returned (e.g. _salt_)

### DB

The database should be reworked to minimise duplication and to save recipes by user. Given that the user can manipulate the response that the AI gives, SQLI should be considered.

### Deployment

The site should be deployed with CI/CD via GitHub Actions. Secrets should be secured. It would be useful to have both a staging and production instance of the site.
There should be thorough test coverage (TDD - do not leave it to the end!). Provide documentation covering the structure of the code and how to get started with local development.

### 2.0.0

### UI

Feedback should be gathered from 1.0.0 to identify any improvements that could be made to the UI flow / design.

Feature additions may include adding a payment option (to contribute to OpenAI costs), displaying 'site favourites', and providing a mechanism for submitting feedback.
For the latter, it would be useful to batch the submissions when received on the dev end (Pub/Sub?) and the possibility of spam should be considered.

### AI

Add functionality for suggesting cocktails that the user would need to buy additional ingredients for, making suggestions based on the average cost of the missing ingredients.