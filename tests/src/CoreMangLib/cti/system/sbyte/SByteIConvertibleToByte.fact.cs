using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_sbyte_SByteIConvertibleToByte_SByteIConvertibleToByte_
    {
        [OuterLoop]
        [Fact]
        public void _system_sbyte_SByteIConvertibleToByte_SByteIConvertibleToByte_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\sbyte\\SByteIConvertibleToByte\\SByteIConvertibleToByte.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
