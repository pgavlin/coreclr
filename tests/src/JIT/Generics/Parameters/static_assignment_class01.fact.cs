using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Parameters_static_assignment_class01_static_assignment_class01_
    {
        [OuterLoop]
        [Fact]
        public void _Parameters_static_assignment_class01_static_assignment_class01_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Parameters\\static_assignment_class01\\static_assignment_class01.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
