using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    public class _unittests_ThrowInFinally_ThrowInFinally_
    {
        [OuterLoop]
        [Fact]
        public void _unittests_ThrowInFinally_ThrowInFinally_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\exceptions\\unittests\\ThrowInFinally\\ThrowInFinally.cmd");
        }
    }
}
