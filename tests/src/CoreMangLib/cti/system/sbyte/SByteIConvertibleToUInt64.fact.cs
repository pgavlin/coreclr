using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_sbyte_SByteIConvertibleToUInt64_SByteIConvertibleToUInt64_
    {
        [OuterLoop]
        [Fact]
        public void _system_sbyte_SByteIConvertibleToUInt64_SByteIConvertibleToUInt64_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\sbyte\\SByteIConvertibleToUInt64\\SByteIConvertibleToUInt64.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
