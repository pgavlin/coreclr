using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _PREFIX_volatile_1_ldloca_ldloca_
    {
        [OuterLoop]
        [Fact]
        public void _PREFIX_volatile_1_ldloca_ldloca_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\PREFIX\\volatile\\1\\ldloca\\ldloca.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
