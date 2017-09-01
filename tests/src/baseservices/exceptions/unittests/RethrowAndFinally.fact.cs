using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    public class _unittests_RethrowAndFinally_RethrowAndFinally_
    {
        [OuterLoop]
        [Fact]
        public void _unittests_RethrowAndFinally_RethrowAndFinally_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\exceptions\\unittests\\RethrowAndFinally\\RethrowAndFinally.cmd");
        }
    }
}
