using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    public class _unittests_RecursiveRethrow_RecursiveRethrow_
    {
        [OuterLoop]
        [Fact]
        public void _unittests_RecursiveRethrow_RecursiveRethrow_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\exceptions\\unittests\\RecursiveRethrow\\RecursiveRethrow.cmd");
        }
    }
}
