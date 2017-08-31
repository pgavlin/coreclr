using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_typecode_TypeCodeBoolean_TypeCodeBoolean_
    {
        [OuterLoop]
        [Fact]
        public void _system_typecode_TypeCodeBoolean_TypeCodeBoolean_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\typecode\\TypeCodeBoolean\\TypeCodeBoolean.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
