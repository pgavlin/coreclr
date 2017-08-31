using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _xxobj_sizeof__il_dbgsizeof__il_dbgsizeof_
    {
        [OuterLoop]
        [Fact]
        public void _xxobj_sizeof__il_dbgsizeof__il_dbgsizeof_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\xxobj\\sizeof\\_il_dbgsizeof\\_il_dbgsizeof.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
