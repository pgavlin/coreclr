using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtime_interopservices_structlayoutattribute_StructLayoutAttributeCtor_StructLayoutAttributeCtor_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtime_interopservices_structlayoutattribute_StructLayoutAttributeCtor_StructLayoutAttributeCtor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtime\\interopservices\\structlayoutattribute\\StructLayoutAttributeCtor\\StructLayoutAttributeCtor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
