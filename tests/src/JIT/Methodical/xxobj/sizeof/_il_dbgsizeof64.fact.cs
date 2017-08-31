using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _xxobj_sizeof__il_dbgsizeof64__il_dbgsizeof64_
    {
        [OuterLoop]
        [Fact]
        public void _xxobj_sizeof__il_dbgsizeof64__il_dbgsizeof64_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\xxobj\\sizeof\\_il_dbgsizeof64\\_il_dbgsizeof64.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
