using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _PREFIX_volatile_1_Desktop_add_add_
    {
        [OuterLoop]
        [Fact]
        public void _PREFIX_volatile_1_Desktop_add_add_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\PREFIX\\volatile\\1\\Desktop\\add\\add.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
