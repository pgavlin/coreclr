using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_int_Int32MaxValue_Int32MaxValue_
    {
        [OuterLoop]
        [Fact]
        public void _system_int_Int32MaxValue_Int32MaxValue_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\int\\Int32MaxValue\\Int32MaxValue.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
