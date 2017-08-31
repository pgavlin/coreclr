using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_targetinvocationexception_TargetInvocationExceptionCtor2_TargetInvocationExceptionCtor2_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_targetinvocationexception_TargetInvocationExceptionCtor2_TargetInvocationExceptionCtor2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\targetinvocationexception\\TargetInvocationExceptionCtor2\\TargetInvocationExceptionCtor2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
