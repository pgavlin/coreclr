using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _xxobj_sizeof__speed_dbgsizeof32__speed_dbgsizeof32_
    {
        [OuterLoop]
        [Fact]
        public void _xxobj_sizeof__speed_dbgsizeof32__speed_dbgsizeof32_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\xxobj\\sizeof\\_speed_dbgsizeof32\\_speed_dbgsizeof32.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
