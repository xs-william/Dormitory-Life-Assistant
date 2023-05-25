namespace Dormitory_Life_Assistant
{
    internal class BuildingService
    {
        //把所有宿舍存到一个list里面
        public List<Building> findBuilding(List<Supervisor> sup)
        {
            List<Building> buildingList = new List<Building>();
            foreach (Supervisor s in sup)
            {
                foreach (Building b1 in s.ManageBuilding)
                {
                    int temp = buildingList.Count;
                    bool status = true;
                    for (int i = 0; i < temp; i++)
                    {
                        {
                            if (b1.BuildingName == buildingList[i].BuildingName)
                            {
                                status = false;  //该宿舍已经在表中了
                            }
                        }
                    }
                    if (status) { buildingList.Add(b1); }
                }
            }
            return buildingList;
        }

        //把一栋楼的所有宿舍存入到一个list中
        public List<Dorm> findDorm(List<Building> buildingList)
        {
            List<Dorm> dormList = new List<Dorm>();
            foreach (Building b in buildingList)
            {
                foreach (Dorm d in b.DormContent)
                {
                    dormList.Add(d);
                }
            }
            return dormList;
        }
        //把所有学生集成到一个list中
        public List<Student> findStudent(List<Dorm> dorm)
        {
            List <Student> studentList = new List<Student>();
            foreach(Dorm d in dorm)
            {
                foreach(Student s in d.Member)
                {
                    studentList.Add(s);
                }
            }
            return studentList;
        }
        public List<Student>accumentStu(List<Supervisor> sup)
        {
            List<Building> buildingList = findBuilding(sup);
            List<Dorm> dormList = findDorm(buildingList);
            List<Student> studentList = findStudent(dormList);
            return studentList;
        }

        /*添加宿舍成员
       将单个宿舍成员加入到某一个宿舍中。系统管理员首先通过这个学生的相关信息找到对应的宿舍，再根据宿舍来更改信息

       将一个宿舍加入到一栋宿舍楼中
    */
        public void addDorm(List<Supervisor> sup, Student stu) {
             List<Building> buildingList=findBuilding(sup);
            //在这里加上try catch语句
                var building =buildingList
                              .Where(b => b.BuildingName == stu.BuildingName)
                              .ToList();
                Building build=building.First();
                var dorm = build.DormContent
                           .Where(d => d.DormNumber == stu.DormNumber)
                           .ToList();
                Dorm dor=dorm.First();
                dor.Member.Add(stu);
        }
        //添加宿管,创建后直接加入到数组里面就行了
        public void addSupDorm(List<Supervisor> sup,Supervisor super)
        {
            sup.Add(super);
        }
         
        //查找宿舍成员并显示信息
        //按学号查询
        public Student searchStuByID(List<Supervisor> sup,string id)
        {
            List<Student>studentList=accumentStu(sup);
            var student = studentList
                .Where(s => s.ID == id)
                .ToList();
            //这里也试着用try catch实现一下比较好
            if (student != null) { 
                Student s = student.First();
                return s;
            }
            else
            {
                return null;
            }
     
        }

        //按姓名查询,有可能有重名的情况，因此返回值为list
        public List<Student> searchStuByName(List<Supervisor> sup,string name)
        {
            List<Student> studentList = accumentStu(sup);
            var student=studentList
                        .Where(s => s.Name == name)
                        .OrderBy(s => s.ID)
                        .ToList();
            return student;
        }

        //按专业查询
        public List<Student> searchStuByDepartment(List<Supervisor> sup, string Department)
        {
            List<Student> studentList = accumentStu(sup);
            var student = studentList
                        .Where(s => s.Department == Department)
                        .ToList();
            return student;
        }

        //按班级查询
        public List<Student> searchStuByClass(List<Supervisor> sup, string Class)
        {
            List<Student> studentList = accumentStu(sup);
            var student = studentList
                        .Where(s => s.Class == Class)
                        .ToList();
            return student;
        }

        //管理员按工号查询
        public Supervisor searchSupByID(List<Supervisor> sup, string id)
        {
            var supervisor = sup
                            .Where(s => s.ID == id)
                            .ToList();
            //这里也试着用try catch实现一下比较好
            if (supervisor != null)
            {
                Supervisor s = supervisor.First();
                return s;
            }
            else
            {
                return null;
            }
        }

        //宿管员按姓名查询
        public List<Supervisor> searchSupByName(List<Supervisor> sup, string name)
        {
            var supervisor = sup
                            .Where(s => s.Name == name);
            return supervisor.ToList();
        }

        //按楼栋名称查询宿管员
        public List<Supervisor> searchSupByBuilding(List<Supervisor> sup, string buildingName)
        {

            List<Supervisor> result = new List<Supervisor>();
            foreach(Supervisor s in sup)
            {
                foreach(Building b in s.ManageBuilding)
                {
                    if(b.BuildingName == buildingName) { 
                        result.Add(s); 
                    }
                }
            }
            return result;
        }

        //根据ID删除宿管
        public void deleteSupDorm(List<Supervisor> sup,string id) { 
            int index=sup.FindIndex(s => s.ID == id);
            if (index > -1)
            {
                sup.RemoveAt(index);
            }
        }

        //根据ID删除学生
        public void deleteDorm(List<Supervisor> sup, string id)
        {
            bool status = true;//说明学生存不存在
            //用try catch说明学生存不存在
            foreach(Supervisor s in sup)
            {
                foreach(Building b in s.ManageBuilding)
                {
                    foreach(Dorm d in b.DormContent)
                    {
                        var student=d.Member
                            .Where(student => student.ID == id)
                            .ToList();
                        if(student != null)
                        {
                            status = false;
                            int index=d.Member.FindIndex(student => student.ID == id);
                            if(index > -1)
                            {
                                d.Member.RemoveAt(index);
                            }
                        }
                    }
                }
            }
            if (!status) { }
            else{
                throw new Exception("添加失败");
            }
        }

        //修改宿舍成员信息
        public void modifyDorm(List<Supervisor> sup,Student student) {
            bool status = true;//说明学生存不存在
            //用try catch说明学生存不存在
            foreach (Supervisor s in sup)
            {
                foreach (Building b in s.ManageBuilding)
                {
                    foreach (Dorm d in b.DormContent)
                    {
                        if (student != null)
                        {
                            var stu = d.Member
                            .Where(st => st.ID == student.ID)
                            .ToList();
                            if (stu != null)
                            {
                                status = false;
                                int index = d.Member.FindIndex(st => st.ID == student.ID);
                                if (index > -1)
                                {
                                    d.Member.RemoveAt(index);
                                }
                            }
                            addDorm(sup,student);
                        }
                    }
                }
            }
            if (!status) { }
            else
            {
                throw new Exception("添加失败");
            }
        }

        //更改宿舍的名称
        public void changeName(List<Supervisor> sup,string oldName,string newName) {
            foreach(Supervisor s in sup)
            {
                foreach(Building b in s.ManageBuilding)
                {
                    if (b.BuildingName == oldName)
                    {
                        b.BuildingName = newName;
                    }
                }
            }
        }

        //为宿管分配宿舍
        public void allocate(List<Supervisor> sup,String buildingName,String id)//这里的id是新宿管的id,buildingName是转换的宿舍的名称
        {
            Building building = new Building();
            //从原来宿管的手中删除掉
            foreach (Supervisor s in sup)
            {
                int index = s.ManageBuilding.FindIndex(b => b.BuildingName == buildingName);
                if (index > -1)
                {
                    building = s.ManageBuilding[index];//将宿舍的信息下载保存
                    s.ManageBuilding.RemoveAt(index);
                }
            }
            foreach(Supervisor s in sup)
            {
                if (id == s.ID)
                {
                    s.ManageBuilding.Add(building);
                }
            }
        }
    }
}
