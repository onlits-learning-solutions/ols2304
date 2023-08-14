<?php declare(strict_types=1);

require '../manual-test/Student.php';

use PHPUnit\Framework\TestCase;
use myorm\manualtest\Student;


final class StudentTest extends TestCase
{
    public function testGotRollNo(): void
    {
        $student = new Student();
        $student->setRollNo(1);
        $this->assertEquals(1, $student->getRollNo());
    }
}