class Solution {
    public boolean validMountainArray(int[] arr) {
        if(arr.length < 3){ 
            return(false);
        }

        if(arr[1] < arr[0]){
            return(false);
        }

        int prev = arr[0];
        boolean asc = true;
        boolean desc = false;
        for(int i = 1; i < arr.length; i++){
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
