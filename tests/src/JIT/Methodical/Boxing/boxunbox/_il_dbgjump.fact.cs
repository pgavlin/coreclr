using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_boxunbox__il_dbgjump__il_dbgjump_
    {
        [OuterLoop]
        [Fact]
        public void _Boxing_boxunbox__il_dbgjump__il_dbgjump_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\boxunbox\\_il_dbgjump\\_il_dbgjump.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
