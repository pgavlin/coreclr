using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Fields_instance_equalnull_class01_instance_equalnull_class01_
    {
        [OuterLoop]
        [Fact]
        public void _Fields_instance_equalnull_class01_instance_equalnull_class01_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Fields\\instance_equalnull_class01\\instance_equalnull_class01.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
