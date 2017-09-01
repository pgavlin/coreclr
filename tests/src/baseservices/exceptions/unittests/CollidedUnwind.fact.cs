using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    public class _unittests_CollidedUnwind_CollidedUnwind_
    {
        [OuterLoop]
        [Fact]
        public void _unittests_CollidedUnwind_CollidedUnwind_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\exceptions\\unittests\\CollidedUnwind\\CollidedUnwind.cmd");
        }
    }
}
