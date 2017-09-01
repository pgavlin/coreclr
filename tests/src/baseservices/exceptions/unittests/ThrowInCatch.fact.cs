using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    public class _unittests_ThrowInCatch_ThrowInCatch_
    {
        [OuterLoop]
        [Fact]
        public void _unittests_ThrowInCatch_ThrowInCatch_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\exceptions\\unittests\\ThrowInCatch\\ThrowInCatch.cmd");
        }
    }
}
