<?php

namespace myorm\manualtest;

class Student
{
    private $rollno;
    private $name;

    public function setRollNo(int $rollno)
    {
        $this->rollno = $rollno;
    }

    public function getRollNo()
    {
        return $this->rollno;
    }

    public function setName(string $name)
    {
        $this->name = $name;
    }

    public function getName()
    {
        return $this->name;
    }

}