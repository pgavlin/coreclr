using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Locals_instance_assignment_struct01_instance_assignment_struct01_
    {
        [OuterLoop]
        [Fact]
        public void _Locals_instance_assignment_struct01_instance_assignment_struct01_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Locals\\instance_assignment_struct01\\instance_assignment_struct01.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
