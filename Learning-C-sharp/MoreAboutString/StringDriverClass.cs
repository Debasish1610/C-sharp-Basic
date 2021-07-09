namespace Learning_C_sharp.MoreAboutString
{
    class StringDriverClass
    {
        public StringDriverClass()
        {
            // Strings are immutable
            //StringEssential stringEssential = new StringEssential();


            //StringBuilder
            //StringBuilder is mutable that means we can modify string afer creating string.
            //We can't do any search operation in string builder. 
            //After any modification operation builder doesn't return any new string. 
            //it return StringBuilder but not new.
            StringBuilderDemo stringBuilderDemo = new StringBuilderDemo();
        }
    }
}
