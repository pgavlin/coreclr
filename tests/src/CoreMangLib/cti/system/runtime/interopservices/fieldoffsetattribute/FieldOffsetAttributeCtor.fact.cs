using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtime_interopservices_fieldoffsetattribute_FieldOffsetAttributeCtor_FieldOffsetAttributeCtor_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtime_interopservices_fieldoffsetattribute_FieldOffsetAttributeCtor_FieldOffsetAttributeCtor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtime\\interopservices\\fieldoffsetattribute\\FieldOffsetAttributeCtor\\FieldOffsetAttributeCtor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
