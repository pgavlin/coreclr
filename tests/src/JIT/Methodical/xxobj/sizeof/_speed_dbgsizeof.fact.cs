using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _xxobj_sizeof__speed_dbgsizeof__speed_dbgsizeof_
    {
        [OuterLoop]
        [Fact]
        public void _xxobj_sizeof__speed_dbgsizeof__speed_dbgsizeof_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\xxobj\\sizeof\\_speed_dbgsizeof\\_speed_dbgsizeof.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
