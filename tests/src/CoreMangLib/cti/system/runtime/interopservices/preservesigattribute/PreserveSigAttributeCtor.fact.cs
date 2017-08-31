using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtime_interopservices_preservesigattribute_PreserveSigAttributeCtor_PreserveSigAttributeCtor_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtime_interopservices_preservesigattribute_PreserveSigAttributeCtor_PreserveSigAttributeCtor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtime\\interopservices\\preservesigattribute\\PreserveSigAttributeCtor\\PreserveSigAttributeCtor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
