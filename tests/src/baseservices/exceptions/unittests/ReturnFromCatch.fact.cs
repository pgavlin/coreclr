using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    public class _unittests_ReturnFromCatch_ReturnFromCatch_
    {
        [OuterLoop]
        [Fact]
        public void _unittests_ReturnFromCatch_ReturnFromCatch_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\exceptions\\unittests\\ReturnFromCatch\\ReturnFromCatch.cmd");
        }
    }
}
