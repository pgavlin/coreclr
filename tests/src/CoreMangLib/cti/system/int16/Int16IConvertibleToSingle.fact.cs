using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_int16_Int16IConvertibleToSingle_Int16IConvertibleToSingle_
    {
        [OuterLoop]
        [Fact]
        public void _system_int16_Int16IConvertibleToSingle_Int16IConvertibleToSingle_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\int16\\Int16IConvertibleToSingle\\Int16IConvertibleToSingle.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
