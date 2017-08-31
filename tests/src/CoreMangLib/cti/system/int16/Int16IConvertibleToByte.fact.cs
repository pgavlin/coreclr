using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_int16_Int16IConvertibleToByte_Int16IConvertibleToByte_
    {
        [OuterLoop]
        [Fact]
        public void _system_int16_Int16IConvertibleToByte_Int16IConvertibleToByte_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\int16\\Int16IConvertibleToByte\\Int16IConvertibleToByte.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
