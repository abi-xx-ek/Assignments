let arr=[
    {
      "MovieName": "The Great Adventure",
      "ActorName": "John Smith",
      "ReleaseDate": "2023-01-15"
    },
    {
      "MovieName": "Mystery in the Woods",
      "ActorName": "Emily Johnson",
      "ReleaseDate": "2022-09-28"
    },
    {
      "MovieName": "Love and Destiny",
      "ActorName": "Michael Brown",
      "ReleaseDate": "2023-05-02"
    },
    {
      "MovieName": "City of Shadows",
      "ActorName": "Sophia Williams",
      "ReleaseDate": "2023-03-12"
    },
    {
      "MovieName": "The Last Stand",
      "ActorName": "William Davis",
      "ReleaseDate": "2022-11-07"
    },
    {
      "MovieName": "Echoes of Time",
      "ActorName": "Olivia Wilson",
      "ReleaseDate": "2022-12-19"
    }
  ];
  






1. List the movie name along with the actor name of those movies released in the year 2022

console.log(arr.filter(x=>new Date(x.ReleaseDate).getFullYear()==2022).map(x=>`actor:${x.ActorName}  movie:${x.MovieName}`));

2. List the movie names released in the year 2023 where the actor is William Davis.

console.log(arr.filter(x=>new Date(x.ReleaseDate).getFullYear()==2023 && x.ActorName=="William Davis").map(x=>x.MovieName));

3. Retrieve the Actor name and release date of the movie “The Last Stand”

console.log(arr.filter(x=>x.MovieName=="The Last Stand").map(x=>`actor:${x.ActorName}  ReleaseDate:${x.ReleaseDate}`));

4. Check whether there is any movie in the list with actor name “John Doe”

console.log(arr.some(x=>x.ActorName=="John Doe"));

5. Display the count of movies where the actor name is "Sophia Williams"

console.log(arr.filter(x=>x.ActorName=="Sophia Williams").length);

6. Insert an element
		{
   			 "MovieName": "The Final Stage",
    			"ActorName": "John Doe",
   	 		"ReleaseDate": "2022-08-11"
 		 }
	as last element

arr.push({
    "MovieName": "The Final Stage",
    "ActorName": "John Doe",
    "ReleaseDate": "2022-08-11"
}
);
console.log(arr)

7. Check whether there exists any duplicate movie names present in the array

const duplicates = new Set(arr).size == arr.length;
if(duplicates==true)
{
    console.log("no duplicates");
   
}
else 
{
    console.log("has duplicates");

}

8. Create a new array starting from the movie "City of Shadows"


const index=arr.findIndex((x => x.MovieName == "City of Shadows"));
console.log(arr.slice(index,arr.length));


9. List the distinct actor names in array

console.log(new Set(arr.map(x=>x.ActorName)));

10. Insert an element
		{
   			 "MovieName": "Rich & Poor",
    			"ActorName": "Johnie Walker",
   	 		"ReleaseDate": "2023-08-11"
 		 }
	as next element to movie “Love and Destiny”


    const ind=arr.findIndex(x=>x.MovieName=="Love and Destiny");

    arr.splice(ind+1,0,{
        "MovieName": "Rich & Poor",
        "ActorName": "Johnie Walker",
        "ReleaseDate": "2023-08-11"
  })
  console.log(arr);



11. Display the count of distinct actor names in array

console.log(new Set(arr.map(x=>x.ActorName)).size);

12. Remove the movie named  "The Last Stand"

const index_=arr.findIndex((x => x.MovieName == "The Last Stand"));
delete arr[index_];
console.log(arr);

13. Check whether all the movies are released after 2021 Dec 31

console.log(arr.every(x=>x.ReleaseDate>"2021-12-31"));

14. Update movie named  "City of Shadows" ‘s release date as  "2023-03-13"

const val=arr.filter(x=>x.MovieName=="City of Shadows");
val[0].ReleaseDate=("2023-03-30");


15. Create a new array of movie names whose movie name length is greater than 10.


const new_arr=arr.filter(x=>x.MovieName.length>10);
console.log(new_arr);















