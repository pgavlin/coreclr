using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_int_Int32MinValue_Int32MinValue_
    {
        [OuterLoop]
        [Fact]
        public void _system_int_Int32MinValue_Int32MinValue_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\int\\Int32MinValue\\Int32MinValue.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
