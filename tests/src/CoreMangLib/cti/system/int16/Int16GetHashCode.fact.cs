using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_int16_Int16GetHashCode_Int16GetHashCode_
    {
        [OuterLoop]
        [Fact]
        public void _system_int16_Int16GetHashCode_Int16GetHashCode_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\int16\\Int16GetHashCode\\Int16GetHashCode.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
