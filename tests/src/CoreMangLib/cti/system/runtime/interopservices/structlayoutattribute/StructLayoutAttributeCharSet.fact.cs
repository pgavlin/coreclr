using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtime_interopservices_structlayoutattribute_StructLayoutAttributeCharSet_StructLayoutAttributeCharSet_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtime_interopservices_structlayoutattribute_StructLayoutAttributeCharSet_StructLayoutAttributeCharSet_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtime\\interopservices\\structlayoutattribute\\StructLayoutAttributeCharSet\\StructLayoutAttributeCharSet.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
