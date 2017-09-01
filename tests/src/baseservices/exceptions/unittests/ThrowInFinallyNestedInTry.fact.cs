using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    public class _unittests_ThrowInFinallyNestedInTry_ThrowInFinallyNestedInTry_
    {
        [OuterLoop]
        [Fact]
        public void _unittests_ThrowInFinallyNestedInTry_ThrowInFinallyNestedInTry_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\exceptions\\unittests\\ThrowInFinallyNestedInTry\\ThrowInFinallyNestedInTry.cmd");
        }
    }
}
