package questions;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

class Employee {
    public int id;
    public int importance;
    public List<Integer> subordinates;

    public Employee(int id, int importance, List<Integer> subordinates) {
        this.id = id;
        this.importance = importance;
        this.subordinates = subordinates;
    }
}

public class EmployeeImportance {

    public int getImportance(List<Employee> employees, int id) {
        int totalImportance = 0;
        for (Employee employee :
                employees) {
            if (employee.id == id) {
                if (employee.subordinates.isEmpty()) {
                    return employee.importance;
                }
                else {
                    totalImportance += employee.importance;
                    for (Integer subordinate :
                            employee.subordinates) {
                        totalImportance += getImportance(employees,subordinate);
                    }
                }
            }
        }
        return totalImportance;
    }



    public static void main(String[] args) {
        EmployeeImportance employeeImportance = new EmployeeImportance();
//        [[1, 5, [2, 3]], [2, 3, []], [3, 3, []]], 1
        List<Integer> list1 = new ArrayList<>();
        list1.add(2);
        list1.add(3);
        Employee e1 = new Employee(1,5,list1);
        List<Integer> list2 = new ArrayList<>();

        Employee e2 = new Employee(2,3,list2);

        Employee e3 = new Employee(3,3,list2);
        List<Employee> listEmployee = new ArrayList<>();
        listEmployee.add(e1);
        listEmployee.add(e2);
        listEmployee.add(e3);
        System.out.println(employeeImportance.getImportance(listEmployee,1));
//        [[1,5,[2,3]],[2,3,[4]],[3,4,[]],[4,1,[]]]
//        List<Integer> list11 = new ArrayList<>();
//        list11.add(2);
//        list11.add(3);
//        Employee e11 = new Employee(1,5,list11);
//        List<Integer> list22 = new ArrayList<>();
//        list22.add(4);
//        Employee e22 = new Employee(2,3,list22);
//        List<Integer> list33 = new ArrayList<>();
//        Employee e33 = new Employee(3,4,list33);
//        List<Integer> list44 = new ArrayList<>();
//        Employee e44 = new Employee(4,1,list44);
//        List<Employee> listEmployee2 = new ArrayList<>();
//        listEmployee2.add(e11);
//        listEmployee2.add(e22);
//        listEmployee2.add(e33);
//        listEmployee2.add(e44);
//        System.out.println(employeeImportance.getImportance(listEmployee2,1));

    }
}
