using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_targetinvocationexception_TargetInvocationExceptionCtor1_TargetInvocationExceptionCtor1_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_targetinvocationexception_TargetInvocationExceptionCtor1_TargetInvocationExceptionCtor1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\targetinvocationexception\\TargetInvocationExceptionCtor1\\TargetInvocationExceptionCtor1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
