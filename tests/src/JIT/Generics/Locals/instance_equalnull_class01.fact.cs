using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Locals_instance_equalnull_class01_instance_equalnull_class01_
    {
        [OuterLoop]
        [Fact]
        public void _Locals_instance_equalnull_class01_instance_equalnull_class01_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Locals\\instance_equalnull_class01\\instance_equalnull_class01.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
