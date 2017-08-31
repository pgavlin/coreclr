using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _stringintern_test2_xassem_test2_xassem_
    {
        [OuterLoop]
        [Fact]
        public void _stringintern_test2_xassem_test2_xassem_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\stringintern\\test2-xassem\\test2-xassem.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
