# Customer Menu App
This project is made to serve customers in a fast food restaurant with a simple-to-use and intuitive user interface.

## Usage and Requirements
There are a few simple requirements to make sure the program runs smoothly. In theory, the program should be able to run in any Windows 8 or newer machine. However, for testing purposes, it would be better to run the program uncompiled within Visual Studio 2022 with .NET Desktop Environment installed.

Note: It is *likely* possible to run this program on Windows 7 or older OR Visual Studio 2019 or older, but **there are no guarantees regarding stability or functionality**. Proceed at your own discretion.

## How to run
This step-by-step tutorial assumes you're running from within Visual Studio IDE with .NET Desktop Environment package installed and ready to use. There are instructions for the standalone version right after this.

1. Open Visual Studio 2022.

2. Click "Clone a repository".

![image](https://user-images.githubusercontent.com/72731965/159424336-e8a4bb45-94c5-4f00-bcdd-5b3718456073.png)

3. Copy and paste `https://github.com/DefinitelyRus/CMA` to the "Repository location". This URL is where this project is located in GitHub.

4. (Optional) Change the path to somewhere you can remember.

5. Click "Clone". This will download the source files and allow you to view, edit, and run the project directly from your computer.

![image](https://user-images.githubusercontent.com/72731965/159426348-1ec8c49d-67ff-4fb7-ab69-e48425d8078e.png)

6. This is what your IDE should look like (see image below).

![image](https://user-images.githubusercontent.com/72731965/159426499-cf0fdcfa-8d1a-4151-9b15-3d9751889a97.png)

Feel free to close the Git Changes window since we won't be using it and it takes up a lot of space on the screen.

![image](https://user-images.githubusercontent.com/72731965/159426712-24d3ace5-ad2a-402f-b2c5-b3e2b30bd4b6.png)

7. In the Solution Explorer window, double-click on "Customer Menu App.sln". This will open the Visual Studio *solution* that contains the project.

![image](https://user-images.githubusercontent.com/72731965/159427068-76d8f618-a548-432b-89ef-474ce1fccd53.png)

8. Click the triangular arrow to expand the CMA. You should see 3 items in it. More specifically, we're looking for "Form1.cs".

![image](https://user-images.githubusercontent.com/72731965/159428360-597ad284-b6e9-4ea0-85c5-88ec6f70691a.png)

9. (Optional) Double-click on Form1.cs. This will open the code editor which contains the source code for the inner workings of the project. There are line-by-line explanations that explain what the code does.

![image](https://user-images.githubusercontent.com/72731965/159434106-30ae1c00-337f-43e6-83c2-be390497f060.png)

10. (Optional) Extend that as well until you see "Form1.Designer.cs". This file contains the source code for the UI you will be interacting with when running the program.

![image](https://user-images.githubusercontent.com/72731965/159427646-164bfa7e-94f8-4d7c-a127-63001a222db0.png)

11. Check the middle-top of your IDE. Make sure the active project is `CMA` **NOT `CMABackendLib`**. You can change this by clicking on the drop-down menu as shown in this image.

![image](https://user-images.githubusercontent.com/72731965/159429906-b7e5c282-a4dd-4e3b-a6b8-1cdd36d62fe4.png)

12. Click on the `CMA` button with the green play icon to its left. This will start compiling the project and run the program.

![image](https://user-images.githubusercontent.com/72731965/159430311-1167e3a3-493a-4d17-8469-e01f925ee9a4.png)

### How to run (No IDE)
**IMPORTANT: This method is not yet ready and may get removed if found to be unnecessary.**
<!-- TODO: Create a release and add an image. -->
1. Go to the [Customer Menu App repository](https://github.com/DefinitelyRus/CMA), then look for a section labeled "Releases" at the right side.
2. Look for a file named "CMA Runnable.zip" and click on it. This will download the ZIP file containing the compiled version for this project, letting you run the app as an EXE file without the need for an IDE.
3. Extract the ZIP file to anywhere you like.
4. Inside the extracted folder is a file named `CMA.exe`. Run it.

## How to use
Congrats! You got the app working. Now let's try to test it.

1. Familiarize yourself with the layout first. There aren't much to look at anyway.

![image](https://user-images.githubusercontent.com/72731965/159433987-6ef06f01-dea2-4188-97ed-e2489d67caf9.png)

2. Start adding items to your order by clicking the up arrow in the item counter below the item's label. Each time you click or enter a new quantity, the price display will change in value corresponding to how much your order costs. Note that the max quantity for each item is 25.

![image](https://user-images.githubusercontent.com/72731965/159434251-f138df1b-71f6-4f4d-9b27-3bccb2fc0621.png)

3. Once done, simply click on Purchase. This will display a pop-up message showing your orders, their price, quantity, and the total price. Upon clicking OK, the UI will reset to its original state where you can start another order.

![image](https://user-images.githubusercontent.com/72731965/159434659-d0577718-c87e-48f2-97cc-b52b666f38ca.png)

4. (Alternate) You can also click on Reset. This will simply put the UI in its original state.

5. Closing the program is as simple as just clicking on the X button at the top-right of the window or using Alt + F4.
