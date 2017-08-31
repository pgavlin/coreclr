using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_seh__relfault__relfault_
    {
        [OuterLoop]
        [Fact]
        public void _Boxing_seh__relfault__relfault_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\seh\\_relfault\\_relfault.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
