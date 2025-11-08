public class Solution {
    public bool ValidMountainArray(int[] arr) {
        if(arr.Length < 3){ 
            return(false);
        }

        if(arr[1] < arr[0]){
            return(false);
        }

        int prev = arr[0];
        bool asc = true;
        bool desc = false;
        for(int i = 1; i < arr.Length; i++){
            if(prev == arr[i]){
                return(false);
            }

            if(asc){
                if(prev > arr[i]){
                    asc = false;
                    desc = true;
                }
            }
            else{
                if(prev < arr[i]){
                    return(false);
                }
            }

            prev = arr[i];
        }

        return(!asc && desc);
    }
}
