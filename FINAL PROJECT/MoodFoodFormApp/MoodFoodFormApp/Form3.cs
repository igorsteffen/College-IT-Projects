using MoodFoodFormApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace MoodFoodFormApp
{
    public partial class Form3 : Form
    {
        private string mood;
        private string restrictions;
        private List<string> suggestedMeals;
        private int currentMealIndex = 0;
        private string analyses;
        private List<string> mealAnalyses;
        private int currentAnalysesIndex = 0;
        private List<Image> mealImages;

        public Form3(string mood, string restrictions, string time, string analyses)
        {
            InitializeComponent();
            this.mood = mood;
            this.restrictions = restrictions;
            suggestedMeals = GetSuggestedMeals(mood, restrictions, time);
            mealAnalyses = GetSuggestedAnalyses(mood, restrictions, time, analyses);

            InitializeRecipeImages();
        }

        private void InitializeRecipeImages()
        {
            mealImages = new List<Image>
            {
                Properties.Resources.happygluten,
                Properties.Resources.happygluten2,
                Properties.Resources.happygluten3,
            };
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            labelMood.Text = Form2.mood;
            labelTime.Text = Form2.time;
            labelRestrictions.Text = Form2.restrictions;
            ShowSuggestion();
            ShowAnalyses();
            ShowRecipeImage(currentMealIndex);
        }

        private void ShowRecipeImage(int mealIndex)
        {
            if (mealIndex >= 0 && mealIndex < mealImages.Count)
            {
                pictureBoxRecipe.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxRecipe.Image = mealImages[mealIndex];
            }
            else
            {
                pictureBoxRecipe.Image = null;
            }
        }

        private List<string> GetSuggestedMeals(string mood, string restrictions, string time)
        {
            List<string> suggestedMeals = new List<string>();

            if (mood == "Happy")
            {
                if (time == "Breakfast")
                {
                    if (restrictions.Contains("Gluten"))
                    {
                        suggestedMeals.Add("Tropical fruit smoothie with coconut milk");
                        suggestedMeals.Add("Spinach and mushroom omelette with tofu");
                        suggestedMeals.Add("Avocado toast with tomato on gluten-free bread");
                    }
                    if (restrictions.Contains("Lactose"))
                    {
                        suggestedMeals.Add("Oatmeal with almond milk and banana");
                        suggestedMeals.Add("Mango and passion fruit smoothie with coconut milk");
                        suggestedMeals.Add("Tapioca with avocado cream and tomato");
                    }
                    if (restrictions.Contains("Vegetarian"))
                    {
                        suggestedMeals.Add("Quinoa salad with grilled vegetables");
                        suggestedMeals.Add("Vegetable wrap with tahini on gluten-free bread");
                        suggestedMeals.Add("Vegetable soup with quinoa and coconut milk");
                    }
                    if (restrictions.Contains("Vegan"))
                    {
                        suggestedMeals.Add("Integral pasta with marinara sauce and vegetables");
                        suggestedMeals.Add("Falafel wrap with salad on gluten-free bread");
                        suggestedMeals.Add("Lentil soup with vegetables and coconut milk");
                    }
                    if (restrictions.Contains("Shellfish"))
                    {
                        suggestedMeals.Add("Quinoa salad with grilled vegetables");
                        suggestedMeals.Add("Vegetable wrap with tahini on gluten-free bread");
                        suggestedMeals.Add("Vegetable soup with quinoa and coconut milk");
                    }
                    if (restrictions.Contains("Nut"))
                    {
                        suggestedMeals.Add("Quinoa salad with grilled vegetables");
                        suggestedMeals.Add("Vegetable wrap with tahini on gluten-free bread");
                        suggestedMeals.Add("Vegetable soup with quinoa and coconut milk");
                    }
                }
                if (time == "Lunch")
                {
                    if (restrictions.Contains("Gluten"))
                    {
                        suggestedMeals.Add("Quinoa salad with grilled vegetables");
                        suggestedMeals.Add("Vegetable wrap with tahini on gluten-free bread");
                        suggestedMeals.Add("Vegetable soup with quinoa and coconut milk");
                    }
                    if (restrictions.Contains("Lactose"))
                    {
                        suggestedMeals.Add("Oatmeal with almond milk and banana");
                        suggestedMeals.Add("Mango and passion fruit smoothie with coconut milk");
                        suggestedMeals.Add("Tapioca with avocado cream and tomato");
                    }
                    if (restrictions.Contains("Vegetarian"))
                    {
                        suggestedMeals.Add("Quinoa salad with grilled vegetables");
                        suggestedMeals.Add("Vegetable wrap with tahini on gluten-free bread");
                        suggestedMeals.Add("Vegetable soup with quinoa and coconut milk");
                    }
                    if (restrictions.Contains("Vegan"))
                    {
                        suggestedMeals.Add("Quinoa salad with grilled vegetables");
                        suggestedMeals.Add("Vegetable wrap with tahini on gluten-free bread");
                        suggestedMeals.Add("Vegetable soup with quinoa and coconut milk");
                    }
                    if (restrictions.Contains("Shellfish"))
                    {
                        suggestedMeals.Add("Quinoa salad with grilled vegetables");
                        suggestedMeals.Add("Vegetable wrap with tahini on gluten-free bread");
                        suggestedMeals.Add("Vegetable soup with quinoa and coconut milk");
                    }
                    if (restrictions.Contains("Nut"))
                    {
                        suggestedMeals.Add("Quinoa salad with grilled vegetables");
                        suggestedMeals.Add("Vegetable wrap with tahini on gluten-free bread");
                        suggestedMeals.Add("Vegetable soup with quinoa and coconut milk");
                    }
                }
                if (time == "Dinner")
                {
                    if (restrictions.Contains("Gluten"))
                    {
                        suggestedMeals.Add("Quinoa salad with grilled vegetables");
                        suggestedMeals.Add("Vegetable wrap with tahini on gluten-free bread");
                        suggestedMeals.Add("Vegetable soup with quinoa and coconut milk");
                    }
                    if (restrictions.Contains("Lactose"))
                    {
                        suggestedMeals.Add("Oatmeal with almond milk and banana");
                        suggestedMeals.Add("Mango and passion fruit smoothie with coconut milk");
                        suggestedMeals.Add("Tapioca with avocado cream and tomato");
                    }
                    if (restrictions.Contains("Vegetarian"))
                    {
                        suggestedMeals.Add("Quinoa salad with grilled vegetables");
                        suggestedMeals.Add("Vegetable wrap with tahini on gluten-free bread");
                        suggestedMeals.Add("Vegetable soup with quinoa and coconut milk");
                    }
                    if (restrictions.Contains("Vegan"))
                    {
                        suggestedMeals.Add("Quinoa salad with grilled vegetables");
                        suggestedMeals.Add("Vegetable wrap with tahini on gluten-free bread");
                        suggestedMeals.Add("Vegetable soup with quinoa and coconut milk");
                    }
                    if (restrictions.Contains("Shellfish"))
                    {
                        suggestedMeals.Add("Quinoa salad with grilled vegetables");
                        suggestedMeals.Add("Vegetable wrap with tahini on gluten-free bread");
                        suggestedMeals.Add("Vegetable soup with quinoa and coconut milk");
                    }
                    if (restrictions.Contains("Nut"))
                    {
                        suggestedMeals.Add("Quinoa salad with grilled vegetables");
                        suggestedMeals.Add("Vegetable wrap with tahini on gluten-free bread");
                        suggestedMeals.Add("Vegetable soup with quinoa and coconut milk");
                    }
                }
            }
            if (mood == "Normal")
            {
                if (time == "Breakfast")
                {
                    if (restrictions.Contains("Gluten"))
                    {
                        suggestedMeals.Add("Pineapple and mint \nsmoothie with almond milk");
                        suggestedMeals.Add("Sweet potato toast \nwith avocado and tomato");
                        suggestedMeals.Add("Gluten-free apple \nand cinnamon muffins");
                    }
                    if (restrictions.Contains("Lactose"))
                    {
                        suggestedMeals.Add("Strawberry smoothie \nwith coconut milk");
                        suggestedMeals.Add("Oat and banana pancakes \nwith maple syrup");
                        suggestedMeals.Add("Spinach and \nmushroom omelette");
                    }
                    if (restrictions.Contains("Vegetarian"))
                    {
                        suggestedMeals.Add("Mango smoothie with \nalmond milk and ginger");
                        suggestedMeals.Add("Whole wheat toast with \nricotta cheese and cherry tomatoes");
                        suggestedMeals.Add("Sweet potato waffles \nwith mixed berry compote");
                    }
                    if (restrictions.Contains("Vegan"))
                    {
                        suggestedMeals.Add("Banana, mango, and \nspinach smoothie with coconut milk");
                        suggestedMeals.Add("Oat and banana pancakes \nwith sugar-free fruit jam");
                        suggestedMeals.Add("Tapioca filled with sautéed \nmushrooms and avocado");
                    }
                    if (restrictions.Contains("Shellfish"))
                    {
                        suggestedMeals.Add("Avocado, banana, and spinach \nsmoothie with almond milk");
                        suggestedMeals.Add("Gluten-free toast with \navocado and tomato cream");
                        suggestedMeals.Add("Blueberry muffins \nwithout seafood");
                    }
                    if (restrictions.Contains("Nut"))
                    {
                        suggestedMeals.Add("Mixed berry smoothie \nwith almond milk");
                        suggestedMeals.Add("Banana pancakes \nwith maple syrup");
                        suggestedMeals.Add("Tapioca filled with sautéed \nmushrooms and spinach");
                    }
                }
                if (time == "Lunch")
                {
                    if (restrictions.Contains("Gluten"))
                    {
                        suggestedMeals.Add("Quinoa salad with grilled \nzucchini and lemon dressing");
                        suggestedMeals.Add("Mushroom and spinach \nwrap in rice paper");
                        suggestedMeals.Add("Lentil soup with vegetables \nand coconut milk");
                    }
                    if (restrictions.Contains("Lactose"))
                    {
                        suggestedMeals.Add("Chickpea salad with cucumber, \ntomato, and lemon dressing");
                        suggestedMeals.Add("Vegetable curry with coconut \nmilk and basmati rice");
                        suggestedMeals.Add("Sweet potato tacos with \nblack beans and avocado");
                    }
                    if (restrictions.Contains("Vegetarian"))
                    {
                        suggestedMeals.Add("Lentil salad with tomato, \ncucumber, feta cheese, and olives");
                        suggestedMeals.Add("Grilled vegetable skewers \nwith Greek yogurt sauce");
                        suggestedMeals.Add("Chickpea curry with \nvegetables and brown rice");
                    }
                    if (restrictions.Contains("Vegan"))
                    {
                        suggestedMeals.Add("Quinoa salad with chickpeas, \ncucumber, tomato, and tahini dressing");
                        suggestedMeals.Add("Falafel wrap with hummus, fresh \nvegetables, and spicy sauce");
                        suggestedMeals.Add("Lentil soup with vegetables \nand coconut milk");
                    }
                    if (restrictions.Contains("Shellfish"))
                    {
                        suggestedMeals.Add("Quinoa salad with grilled \nvegetables and lemon dressing");
                        suggestedMeals.Add("Vegetable wrap with guacamole \nin corn tortilla");
                        suggestedMeals.Add("Pumpkin soup with ginger \nand coconut milk");
                    }
                    if (restrictions.Contains("Nut"))
                    {
                        suggestedMeals.Add("Chickpea salad with roasted \nvegetables and balsamic vinaigrette");
                        suggestedMeals.Add("Grilled tofu sandwich with \nwhole wheat bread, lettuce, and tomato");
                        suggestedMeals.Add("Vegetable quiche \nwithout nuts");
                    }
                }
                if (time == "Diner")
                {
                    if (restrictions.Contains("Gluten"))
                    {
                        suggestedMeals.Add("Roasted cauliflower tacos \nwith tomato sauce and guacamole");
                        suggestedMeals.Add("Pumpkin and broccoli \nrisotto without gluten");
                        suggestedMeals.Add("Zucchini spaghetti \nwith lentil meatballs");
                    }
                    if (restrictions.Contains("Lactose"))
                    {
                        suggestedMeals.Add("Mushroom risotto with \nalmond milk and fresh herbs");
                        suggestedMeals.Add("Zucchini spaghetti with \nhomemade tomato sauce and vegetarian meatballs");
                        suggestedMeals.Add("Grilled tofu wrap with \nvegetables and peanut sauce");
                    }
                    if (restrictions.Contains("Vegetarian"))
                    {
                        suggestedMeals.Add("Thin crust vegetarian \npizza with homemade tomato sauce");
                        suggestedMeals.Add("Mushroom risotto with \nvegetarian parmesan cheese");
                        suggestedMeals.Add("Zucchini spaghetti with \npesto sauce and cherry tomatoes");
                    }
                    if (restrictions.Contains("Vegan"))
                    {
                        suggestedMeals.Add("Stir-fried vegetables \nwith tofu and ginger-soy sauce");
                        suggestedMeals.Add("Chickpea and vegetable \ncurry with basmati rice");
                        suggestedMeals.Add("Ratatouille with grilled \ntofu and aromatic herbs");
                    }
                    if (restrictions.Contains("Shellfish"))
                    {
                        suggestedMeals.Add("Mushroom and asparagus \nrisotto without seafood");
                        suggestedMeals.Add("Whole wheat pasta with \nhomemade tomato sauce and vegetables");
                        suggestedMeals.Add("Chickpea burger with \nbaked potatoes");
                    }
                    if (restrictions.Contains("Nut"))
                    {
                        suggestedMeals.Add("Ratatouille with \nbrown rice");
                        suggestedMeals.Add("Lentil soup with \nfresh vegetables");
                        suggestedMeals.Add("Falafel with kale \nsalad and tahini dressing");
                    }
                }
            }

            if (mood == "Sad")
            {
                if (time == "Breakfast")
                {
                    if (restrictions.Contains("Gluten"))
                    {
                        suggestedMeals.Add("Banana and kiwi smoothie with almond milk");
                        suggestedMeals.Add("Oatmeal pancakes with gluten-free apple compote");
                        suggestedMeals.Add("Sweet potato toasts with avocado and tomato");
                    }
                    if (restrictions.Contains("Lactose"))
                    {
                        suggestedMeals.Add("Blueberry and coconut smoothie with almond milk");
                        suggestedMeals.Add("Oatmeal and banana pancakes with maple syrup");
                        suggestedMeals.Add("Spinach omelette with mushrooms and tomato");
                    }
                    if (restrictions.Contains("Vegetarian"))
                    {
                        suggestedMeals.Add("Pineapple and mango smoothie with coconut milk and ginger");
                        suggestedMeals.Add("Whole grain toast with creamy ricotta and cherry tomatoes");
                        suggestedMeals.Add("Sweet potato waffles with mixed berry compote");
                    }
                    if (restrictions.Contains("Vegan"))
                    {
                        suggestedMeals.Add("Banana, mango, and spinach smoothie with coconut milk");
                        suggestedMeals.Add("Oatmeal and banana pancakes with sugar-free fruit jelly");
                        suggestedMeals.Add("Tapioca stuffed with sautéed mushrooms and avocado");
                    }
                    if (restrictions.Contains("Shellfish"))
                    {
                        suggestedMeals.Add("Avocado, banana, and spinach smoothie with almond milk");
                        suggestedMeals.Add("Gluten-free toast with avocado cream and tomato");
                        suggestedMeals.Add("Blueberry muffins without seafood");
                    }
                    if (restrictions.Contains("Nut"))
                    {
                        suggestedMeals.Add("Mixed berry smoothie with almond milk");
                        suggestedMeals.Add("Banana pancakes with maple syrup");
                        suggestedMeals.Add("Tapioca stuffed with sautéed mushrooms and spinach");
                    }
                }
                if (time == "Lunch")
                {
                    if (restrictions.Contains("Gluten"))
                    {
                        suggestedMeals.Add("Quinoa salad with roasted pumpkin and lemon vinaigrette");
                        suggestedMeals.Add("Sautéed mushroom wrap with spinach in rice paper");
                        suggestedMeals.Add("Lentil soup with vegetables and coconut milk");
                    }
                    if (restrictions.Contains("Lactose"))
                    {
                        suggestedMeals.Add("Chickpea salad with cucumber, tomato, and lemon dressing");
                        suggestedMeals.Add("Vegetable curry with coconut milk and basmati rice");
                        suggestedMeals.Add("Sweet potato tacos stuffed with black beans and avocado");
                    }
                    if (restrictions.Contains("Vegetarian"))
                    {
                        suggestedMeals.Add("Lentil salad with tomato, cucumber, feta cheese, and olives");
                        suggestedMeals.Add("Grilled vegetable skewers with Greek yogurt sauce and herbs");
                        suggestedMeals.Add("Chickpea curry with vegetables and brown rice");
                    }
                    if (restrictions.Contains("Vegan"))
                    {
                        suggestedMeals.Add("Quinoa salad with chickpeas, cucumber, tomato, and tahini dressing");
                        suggestedMeals.Add("Falafel wrap with hummus, fresh vegetables, and spicy sauce");
                        suggestedMeals.Add("Lentil soup with vegetables and coconut milk");
                    }
                    if (restrictions.Contains("Shellfish"))
                    {
                        suggestedMeals.Add("Quinoa salad with grilled vegetables and lemon dressing");
                        suggestedMeals.Add("Vegetable wrap with guacamole on corn tortilla");
                        suggestedMeals.Add("Pumpkin soup with ginger and coconut milk");
                    }
                    if (restrictions.Contains("Nut"))
                    {
                        suggestedMeals.Add("Chickpea salad with roasted vegetables and balsamic vinaigrette");
                        suggestedMeals.Add("Grilled tofu sandwich with whole grain bread, lettuce, and tomato");
                        suggestedMeals.Add("Vegetable quiche without nuts");
                    }
                }
                if (time == "Dinner")
                {
                    if (restrictions.Contains("Gluten"))
                    {
                        suggestedMeals.Add("Roasted cauliflower tacos with mango salsa and guacamole");
                        suggestedMeals.Add("Wild mushroom risotto without gluten");
                        suggestedMeals.Add("Zucchini spaghetti with lentil meatballs and marinara sauce");
                    }
                    if (restrictions.Contains("Lactose"))
                    {
                        suggestedMeals.Add("Mushroom risotto with almond milk and fresh herbs");
                        suggestedMeals.Add("Zucchini spaghetti with homemade tomato sauce and vegetarian meatballs");
                        suggestedMeals.Add("Grilled tofu wrap with vegetables and peanut sauce");
                    }
                    if (restrictions.Contains("Vegetarian"))
                    {
                        suggestedMeals.Add("Vegetarian pizza with thin crust and homemade tomato sauce");
                        suggestedMeals.Add("Mushroom risotto with vegetarian parmesan cheese");
                        suggestedMeals.Add("Zucchini spaghetti with pesto sauce and cherry tomatoes");
                    }
                    if (restrictions.Contains("Vegan"))
                    {
                        suggestedMeals.Add("Stir-fried vegetables with tofu and ginger soy sauce");
                        suggestedMeals.Add("Chickpea and vegetable curry with basmati rice");
                        suggestedMeals.Add("Ratatouille with grilled tofu and fresh herbs");
                    }
                    if (restrictions.Contains("Shellfish"))
                    {
                        suggestedMeals.Add("Mushroom and asparagus risotto without seafood");
                        suggestedMeals.Add("Whole wheat pasta with homemade tomato sauce and vegetables");
                        suggestedMeals.Add("Chickpea burger with roasted potatoes");
                    }
                    if (restrictions.Contains("Nut"))
                    {
                        suggestedMeals.Add("Ratatouille with brown rice");
                        suggestedMeals.Add("Lentil soup with fresh vegetables");
                        suggestedMeals.Add("Falafel with kale salad and tahini sauce");
                    }
                }
            }
            return suggestedMeals;
        }

        private List<string> GetSuggestedAnalyses(string mood, string restrictions, string time, string analyses)
        {
            List<string> mealAnalyses = new List<string>();

            if (mood == "Happy")
            {
                if (time == "Breakfast" || time == "Lunch" || time == "Diner")
                {
                    if (restrictions.Contains("Gluten"))
                    {
                        mealAnalyses.Add("Analysis: These dishes are gluten-free " +
                            "\nand include a variety of ingredients that promote " +
                            "\nfeelings of happiness, such as fresh fruits, vegetables, " +
                            "\nplant-based proteins, and healthy fats. The balance " +
                            "\nbetween proteins, complex carbohydrates, and healthy " +
                            "\nfats in these options helps stabilize blood sugar levels " +
                            "\nand promote a state of happiness and well-being.");
                    }
                    if (restrictions.Contains("Lactose"))
                    {
                        mealAnalyses.Add("Analysis: These lactose-free dishes are rich " +
                            "\nin colors and flavors, which contributes to an increase in " +
                            "\nhappiness. Foods like avocado, coconut, and banana are rich " +
                            "\nin tryptophan, which aids in the production of serotonin, the " +
                            "\nneurotransmitter of well-being.");

                    }
                    if (restrictions.Contains("Vegetarian"))
                    {
                        mealAnalyses.Add("Analysis: A vegetarian diet rich in colors, flavors, " +
                            "\nand nutrients contributes to a state of happiness due to the " +
                            "\nconsumption of whole and fresh foods. The options include sources " +
                            "\nof complex carbohydrates, plant-based proteins, and healthy fats, " +
                            "\nwhich help maintain energy levels and promote serotonin production.");

                    }
                    if (restrictions.Contains("Vegan"))
                    {
                        mealAnalyses.Add("Analysis: A vegan diet, based on plant-based foods, can " +
                            "\npromote a state of happiness due to its richness in nutrients and health " +
                            "\nbenefits. Ingredients such as quinoa, chickpeas, tofu, and vegetables are " +
                            "\nsources of sustainable energy that can contribute to a positive mood and a " +
                            "\nsense of well-being.");
                    }
                    if (restrictions.Contains("Shellfish"))
                    {
                        mealAnalyses.Add("Analysis: The options completely avoid seafood, incorporating " +
                            "\na variety of foods that are known to uplift mood, such as fresh fruits, vegetables, " +
                            "\nand nutrient-rich plant-based alternatives. The combination of fiber-rich foods, " +
                            "\nproteins, and healthy fats contributes to overall well-being and a sense of happiness.");
                    }
                    if (restrictions.Contains("Nut"))
                    {
                        mealAnalyses.Add("Analysis: By eliminating nuts, these dishes offer safe and nutritious " +
                            "\nalternatives that sustain energy and joy through ingredients rich in vitamins, minerals, " +
                            "\nand antioxidants, all known to support a positive mood and overall health.");
                    }
                }

            }

            if (mood == "Normal")
            {
                if (time == "Breakfast" || time == "Lunch" || time == "Diner")
                {
                    if (restrictions.Contains("Gluten"))
                    {
                        mealAnalyses.Add("Analysis: These gluten-free options, rich in vegetables " +
                            "\nand plant-based proteins, can help promote a happy mood. Ingredients " +
                            "\nlike pineapple, zucchini, lentils, and pumpkin are known for their mood-boosting " +
                            "\nbenefits and can contribute to an overall sense of well-being.");
                    }
                    if (restrictions.Contains("Lactose"))
                    {
                        mealAnalyses.Add("Analysis: These lactose-free options are packed with flavors " +
                            "\nand textures that can uplift the mood. Ingredients like strawberry, chickpea, " +
                            "\navocado, and mushrooms are known for their happiness-promoting properties and " +
                            "\nemotional well-being.");

                    }
                    if (restrictions.Contains("Vegetarian"))
                    {
                        mealAnalyses.Add("Analysis: A well-planned vegetarian diet can contribute to a happy " +
                            "\nmood by offering a variety of nutrient-rich foods. Ingredients like mango, lentil, " +
                            "\nfeta cheese, and mushrooms can stimulate the release of neurotransmitters associated " +
                            "\nwith happiness.");

                    }
                    if (restrictions.Contains("Vegan"))
                    {
                        mealAnalyses.Add("Analysis: A vegan diet, based on plant-based foods, can promote a state " +
                            "\nof happiness due to its nutrient-richness and health benefits. Ingredients like quinoa, " +
                            "\nchickpeas, tofu, and vegetables are sustainable energy sources that can contribute to a " +
                            "\npositive mood and a sense of well-being.");
                    }
                    if (restrictions.Contains("Shellfish"))
                    {
                        mealAnalyses.Add("Analysis: These seafood-free options incorporate a variety of foods that can " +
                            "\nimprove mood. Ingredients like avocado, quinoa, pumpkin, and mushrooms are known for their " +
                            "\npositive effects on emotional well-being and can help promote a state of happiness.");
                    }
                    if (restrictions.Contains("Nut"))
                    {
                        mealAnalyses.Add("Analysis: These nut-free options offer a variety of nutrients that may " +
                            "\nhave a neutral effect on mood. Ingredients like fruits, vegetables, and lean protein " +
                            "\nsources are healthy sources of energy that can contribute to emotional well-being.");
                    }
                }
            }

            if (mood == "Sad")
            {
                if (time == "Breakfast" || time == "Lunch" || time == "Diner")
                {
                    if (restrictions.Contains("Gluten"))
                    {
                        mealAnalyses.Add("Analysis: These gluten-free options, featuring a variety of vegetables " +
                            "\nand plant-based proteins, can help uplift the mood. Ingredients like banana, kiwi, quinoa, " +
                            "\nand pumpkin are known for their positive effects on mood and can contribute to an overall " +
                            "\nsense of happiness.");
                    }
                    if (restrictions.Contains("Lactose"))
                    {
                        mealAnalyses.Add("Analysis: These lactose-free options are rich in flavors and textures that " +
                            "\ncan elevate the mood. Ingredients like blueberry, coconut, chickpeas, and mushrooms are " +
                            "\nknown for their happiness-promoting properties and emotional well-being.");

                    }
                    if (restrictions.Contains("Vegetarian"))
                    {
                        mealAnalyses.Add("Analysis: A balanced vegetarian diet can contribute to a happier mood by " +
                            "\noffering a variety of nutrient-rich foods. Ingredients like pineapple, mango, lentil, and " +
                            "\nmushrooms can stimulate the release of neurotransmitters associated with happiness.");

                    }
                    if (restrictions.Contains("Vegan"))
                    {
                        mealAnalyses.Add("Analysis: A vegan diet, based on plant foods, can promote a state of happiness " +
                            "\ndue to its nutrient richness and health benefits. Ingredients like quinoa, chickpeas, tofu, " +
                            "\nand vegetables are sustainable energy sources that can contribute to a positive mood and a " +
                            "\nsense of well-being.");
                    }
                    if (restrictions.Contains("Shellfish"))
                    {
                        mealAnalyses.Add("Analysis: These seafood-free options incorporate a variety of foods that can " +
                            "\nimprove mood. Ingredients like avocado, quinoa, pumpkin, and mushrooms are known for their " +
                            "\npositive effects on emotional well-being and can help promote a state of happiness.");
                    }
                    if (restrictions.Contains("Nut"))
                    {
                        mealAnalyses.Add("Analysis: These nut-free options offer a variety of nutrients that may have " +
                            "\na neutral effect on mood. Ingredients like fruits, vegetables, and lean protein sources " +
                            "\nare healthy sources of energy that can contribute to emotional well-being.");
                    }
                }
            }
            return mealAnalyses;
        }

        private void ShowSuggestion()
        {
            if (suggestedMeals.Count > 0)
            {
                labelSuggestion.Text = suggestedMeals[currentMealIndex];
            }
            else
            {
                labelSuggestion.Text = "No more suggestions.";
            }
        }

        private void ShowAnalyses()
        {
            if (mealAnalyses.Count > 0)
            {
                labelAnalyses.Text = mealAnalyses[currentAnalysesIndex];
            }
            else
            {
                labelAnalyses.Text = "No more analyses.";
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            currentMealIndex--;
            if (currentMealIndex < 0)
            {
                currentMealIndex = suggestedMeals.Count - 1;
            }
            ShowSuggestion();

            currentAnalysesIndex--;
            if (currentAnalysesIndex < 0)
            {
                currentAnalysesIndex = mealAnalyses.Count - 1;
            }
            ShowAnalyses();
            ShowRecipeImage(currentMealIndex);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            currentMealIndex++;
            if (currentMealIndex >= suggestedMeals.Count)
            {
                currentMealIndex = 0;
            }
            ShowSuggestion();

            currentAnalysesIndex++;
            if (currentAnalysesIndex >= mealAnalyses.Count)
            {
                currentAnalysesIndex = 0;
            }
            ShowAnalyses();
            ShowRecipeImage(currentMealIndex);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }
    }
}
