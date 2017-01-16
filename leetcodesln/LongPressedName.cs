namespace leetcodesln
{
    public class LongPressedName
    {
        public bool IsLongPressedName(string name, string typed)
        {
            var name_index_ptr = 0;
            for (int i = 0; i < typed.Length; i++)
            {
                if(typed[i]== name[name_index_ptr]) continue;
                else
                {
                    if(typed[i] == name[++name_index_ptr]) continue;
                    else return false;
                }
            }
            return name_index_ptr == name.Length-1;
        }
    }
}