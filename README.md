# SchoolManagementSystem_SaeedMosaffer
The code was done as required with these changes and additions:
I created an Affiliate class with the common attributes between the student and the teacher
In the student class, I added a method to delete the course as well

In the data structure, I used the following:
for students, teachers, and courses im used Dictionary<int, T>
For courses associated with students and teachers, im used HashSet<T> to avoid duplicates while maintaining efficient insertion and deletion.

Data Structure: Dictionary<TKey, TValue>.
Reason: If you need to find a student, teacher, or course by their Id frequently, a dictionary provides O(1) average lookup time

Data Structure: HashSet<T>.
Reason: HashSet<T> if you need to ensure no duplicate entries (e.g., a student can't enroll in the same course twice).

In the course class, I added two methods, which are as follows:

Equals Method:
This method is used to determine equality between two Course objects.
It checks if the given object (obj) is a Course and compares their Id values.
This ensures that two Course objects are considered equal if they have the same ID, regardless of other properties.

GetHashCode Method:
This method generates a hash code for the Course object, which is used in hash-based collections like HashSet and Dictionary.
The hash code is derived from the Id property, ensuring that the Id uniquely identifies the object in collections.
