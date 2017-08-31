using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Parameters_instance_passing_struct01_instance_passing_struct01_
    {
        [OuterLoop]
        [Fact]
        public void _Parameters_instance_passing_struct01_instance_passing_struct01_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Parameters\\instance_passing_struct01\\instance_passing_struct01.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
