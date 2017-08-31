using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _xxobj_sizeof__il_dbgsizeof32__il_dbgsizeof32_
    {
        [OuterLoop]
        [Fact]
        public void _xxobj_sizeof__il_dbgsizeof32__il_dbgsizeof32_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\xxobj\\sizeof\\_il_dbgsizeof32\\_il_dbgsizeof32.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
