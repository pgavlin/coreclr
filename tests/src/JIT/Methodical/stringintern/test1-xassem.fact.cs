using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _stringintern_test1_xassem_test1_xassem_
    {
        [OuterLoop]
        [Fact]
        public void _stringintern_test1_xassem_test1_xassem_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\stringintern\\test1-xassem\\test1-xassem.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
