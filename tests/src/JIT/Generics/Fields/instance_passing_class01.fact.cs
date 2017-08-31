using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Fields_instance_passing_class01_instance_passing_class01_
    {
        [OuterLoop]
        [Fact]
        public void _Fields_instance_passing_class01_instance_passing_class01_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Fields\\instance_passing_class01\\instance_passing_class01.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
